using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System149 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component444> _p1;
EcsPool<Component326> _p2;
EcsPool<Component443> _p3;
EcsPool<Component406> _p4;
EcsPool<Component15> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component444>().Inc<Component326>().Inc<Component443>().Inc<Component406>().End();
   _p1 = _world.GetPool<Component444>();
   _p2 = _world.GetPool<Component326>();
   _p3 = _world.GetPool<Component443>();
   _p4 = _world.GetPool<Component406>();
   _pl0 = _world.GetPool<Component15>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}

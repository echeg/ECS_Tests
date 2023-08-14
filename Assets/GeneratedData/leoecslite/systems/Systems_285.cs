using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System285 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component441> _p1;
EcsPool<Component242> _p2;
EcsPool<Component15> _p3;
EcsPool<Component377> _p4;
EcsPool<Component278> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component441>().Inc<Component242>().Inc<Component15>().Inc<Component377>().End();
   _p1 = _world.GetPool<Component441>();
   _p2 = _world.GetPool<Component242>();
   _p3 = _world.GetPool<Component15>();
   _p4 = _world.GetPool<Component377>();
   _pl0 = _world.GetPool<Component278>();
 }
 public void Run (IEcsSystems systems) {
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

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System166 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component431> _p1;
EcsPool<Component209> _p2;
EcsPool<Component61> _p3;
EcsPool<Component202> _p4;
EcsPool<Component320> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component431>().Inc<Component209>().Inc<Component61>().Inc<Component202>().End();
   _p1 = _world.GetPool<Component431>();
   _p2 = _world.GetPool<Component209>();
   _p3 = _world.GetPool<Component61>();
   _p4 = _world.GetPool<Component202>();
   _pl0 = _world.GetPool<Component320>();
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

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System458 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component191> _p1;
EcsPool<Component54> _p2;
EcsPool<Component489> _p3;
EcsPool<Component177> _p4;
EcsPool<Component358> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component191>().Inc<Component54>().Inc<Component489>().Inc<Component177>().End();
   _p1 = _world.GetPool<Component191>();
   _p2 = _world.GetPool<Component54>();
   _p3 = _world.GetPool<Component489>();
   _p4 = _world.GetPool<Component177>();
   _pl0 = _world.GetPool<Component358>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

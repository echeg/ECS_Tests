using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System481 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component396> _p1;
EcsPool<Component462> _p2;
EcsPool<Component28> _p3;
EcsPool<Component284> _p4;
EcsPool<Component150> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component396>().Inc<Component462>().Inc<Component28>().Inc<Component284>().End();
   _p1 = _world.GetPool<Component396>();
   _p2 = _world.GetPool<Component462>();
   _p3 = _world.GetPool<Component28>();
   _p4 = _world.GetPool<Component284>();
   _pl0 = _world.GetPool<Component150>();
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

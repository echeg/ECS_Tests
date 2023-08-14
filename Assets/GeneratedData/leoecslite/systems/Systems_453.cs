using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System453 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component474> _p1;
EcsPool<Component417> _p2;
EcsPool<Component248> _p3;
EcsPool<Component356> _p4;
EcsPool<Component173> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component474>().Inc<Component417>().Inc<Component248>().Inc<Component356>().End();
   _p1 = _world.GetPool<Component474>();
   _p2 = _world.GetPool<Component417>();
   _p3 = _world.GetPool<Component248>();
   _p4 = _world.GetPool<Component356>();
   _pl0 = _world.GetPool<Component173>();
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

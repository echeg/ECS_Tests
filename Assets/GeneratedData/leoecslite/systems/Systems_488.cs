using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System488 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component101> _p1;
EcsPool<Component52> _p2;
EcsPool<Component80> _p3;
EcsPool<Component470> _p4;
EcsPool<Component247> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component101>().Inc<Component52>().Inc<Component80>().Inc<Component470>().End();
   _p1 = _world.GetPool<Component101>();
   _p2 = _world.GetPool<Component52>();
   _p3 = _world.GetPool<Component80>();
   _p4 = _world.GetPool<Component470>();
   _pl0 = _world.GetPool<Component247>();
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

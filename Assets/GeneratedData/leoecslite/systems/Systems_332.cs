using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System332 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component498> _p1;
EcsPool<Component386> _p2;
EcsPool<Component472> _p3;
EcsPool<Component14> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component498>().Inc<Component386>().Inc<Component472>().End();
   _p1 = _world.GetPool<Component498>();
   _p2 = _world.GetPool<Component386>();
   _p3 = _world.GetPool<Component472>();
   _pl0 = _world.GetPool<Component14>();
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

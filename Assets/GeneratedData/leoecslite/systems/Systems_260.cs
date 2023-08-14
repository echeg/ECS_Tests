using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System260 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component402> _p1;
EcsPool<Component200> _p2;
EcsPool<Component408> _p3;
EcsPool<Component171> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component402>().Inc<Component200>().Inc<Component408>().End();
   _p1 = _world.GetPool<Component402>();
   _p2 = _world.GetPool<Component200>();
   _p3 = _world.GetPool<Component408>();
   _pl0 = _world.GetPool<Component171>();
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

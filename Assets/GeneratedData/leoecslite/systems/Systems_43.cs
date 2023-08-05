using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System43 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component373> _p1;
EcsPool<Component248> _p2;
EcsPool<Component129> _p3;
EcsPool<Component222> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component373>().Inc<Component248>().Inc<Component129>().Inc<Component222>().End();
   _p1 = _world.GetPool<Component373>();
   _p2 = _world.GetPool<Component248>();
   _p3 = _world.GetPool<Component129>();
   _p4 = _world.GetPool<Component222>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

}

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System101 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component402> _p1;
EcsPool<Component179> _p2;
EcsPool<Component232> _p3;
EcsPool<Component331> _p4;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component402>().Inc<Component179>().Inc<Component232>().Inc<Component331>().End();
   _p1 = _world.GetPool<Component402>();
   _p2 = _world.GetPool<Component179>();
   _p3 = _world.GetPool<Component232>();
   _p4 = _world.GetPool<Component331>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

}

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System55 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component333> _p1;
EcsPool<Component461> _p2;
EcsPool<Component98> _p3;
EcsPool<Component78> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component333>().Inc<Component461>().Inc<Component98>().Inc<Component78>().End();
   _p1 = _world.GetPool<Component333>();
   _p2 = _world.GetPool<Component461>();
   _p3 = _world.GetPool<Component98>();
   _p4 = _world.GetPool<Component78>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
